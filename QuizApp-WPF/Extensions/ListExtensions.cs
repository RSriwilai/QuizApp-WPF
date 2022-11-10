using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuizApp_WPF.Extensions;

public static class ListExtensions
{
    public static async Task Replace<T>(this List<T> list, Predicate<T> oldItemSelector, T newItem)
    {
        await Task.Run(() =>
        {
            var oldItemIndex = list.FindIndex(oldItemSelector);
            list[oldItemIndex] = newItem;
        });
    }
}