﻿using System.Runtime.Serialization;
using System.Text;

namespace YGOPRO.Extensions;

public static class StringExtensions
{
    public static string UnPascalCase(this string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return "";
        var newText = new StringBuilder(text.Length * 2);
        newText.Append(text[0]);
        for (var i = 1; i < text.Length; i++)
        {
            var currentUpper = char.IsUpper(text[i]);
            var prevUpper = char.IsUpper(text[i - 1]);
            var nextUpper = (text.Length > i + 1) ? char.IsUpper(text[i + 1]) || char.IsWhiteSpace(text[i + 1]) : prevUpper;
            var spaceExists = char.IsWhiteSpace(text[i - 1]);
            if (currentUpper && !spaceExists && (!nextUpper || !prevUpper))
                newText.Append(' ');
            newText.Append(text[i]);
        }

        return newText.ToString();
    }
}