using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace OCR.Tool.API.Utils.MappingExtend.Helper
{
    /// <summary>
    /// 通过生成表达式目录树来copy模型  泛型缓存
    /// </summary>
    /// <typeparam name="TIn">需要被copy的模型</typeparam>
    /// <typeparam name="TOut">返回copy的模型</typeparam>
    public class ExpressionGenericMapper<TIn, TOut>
    {
        private static readonly Func<TIn, TOut> _FUNC = null;

        static ExpressionGenericMapper()
        {
            ParameterExpression parameterExpression = Expression.Parameter(typeof(TIn), "p");
            List<MemberBinding> memberBindingList = new List<MemberBinding>();
            foreach (var item in typeof(TOut).GetProperties())
            {
                if (typeof(TIn).GetProperty(item.Name) == null) continue;
                MemberExpression property = Expression.Property(parameterExpression, typeof(TIn).GetProperty(item.Name) ?? throw new InvalidOperationException());
                MemberBinding memberBinding = Expression.Bind(item, property);
                memberBindingList.Add(memberBinding);
            }
            foreach (var item in typeof(TOut).GetFields())
            {
                if (typeof(TIn).GetField(item.Name) == null) continue;
                MemberExpression property = Expression.Field(parameterExpression, typeof(TIn).GetField(item.Name));
                MemberBinding memberBinding = Expression.Bind(item, property);
                memberBindingList.Add(memberBinding);
            }
            MemberInitExpression memberInitExpression = Expression.MemberInit(Expression.New(typeof(TOut)), memberBindingList.ToArray());
            Expression<Func<TIn, TOut>> lambda = Expression.Lambda<Func<TIn, TOut>>(memberInitExpression, new ParameterExpression[]
            {
                parameterExpression
            });
            _FUNC = lambda.Compile();//拼装是一次性的
        }

        public static TOut Trans(TIn t)
        {
            return _FUNC(t);
        }
    }
}