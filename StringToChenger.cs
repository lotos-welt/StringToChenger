/************************************************
StringToChenger.cs

Copyright (c) 2016 LotosLabo

This software is released under the MIT License.
http://opensource.org/licenses/mit-license.php
************************************************/

using UnityEngine;
using System.Collections;
using System.Globalization;
using System.Text.RegularExpressions;

/* 文字列変換クラス. */
public class StringToChenger : MonoBehaviour {

    /// <summary>
    /// 変換タイプ.
    /// </summary>
    public enum ChangeTypes {
        None = -1,
        Upper,
        Lower
    }

    /// <summary>
    /// 変換タイプデフォルト.
    /// </summary>
    public ChangeTypes Type = ChangeTypes.None;

    /// <summary>
    /// 先頭文字を大文字、小文字に変換.
    /// </summary>
    /// <param name="text">文字列.</param>
    /// <param name="type">変換タイプ.</param>
    /// <returns>変換された文字列.</returns>
    public static string HeadCharToChanger(string text, int type) {
        // アルファベットか判断(半角英字か、全角英字か).
        if (!Regex.IsMatch(text, @"^[ａ-ｚＡ-Ｚ]+$") && !Regex.IsMatch(text, @"^[a-zA-Z]+$")) {
            return null;
        }
        string changedText = string.Empty;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        switch ((ChangeTypes)(type)) {
            case ChangeTypes.Upper:
                changedText = textInfo.ToUpper(text[0]) + text.Substring(1);
                break;
            case ChangeTypes.Lower:
                changedText = textInfo.ToLower(text[0]) + text.Substring(1);
                break;
        }
        return changedText;
    }

    /// <summary>
    /// 文字列を大文字、小文字に変換.
    /// </summary>
    /// <param name="text">文字列.</param>
    /// <param name="type">変換タイプ.</param>
    /// <returns>変換された文字列.</returns>
    public static string StringToChanger(string text, int type) {
        // アルファベットか判断(半角英字か、全角英字か).
        if (!Regex.IsMatch(text, @"^[ａ-ｚＡ-Ｚ]+$") && !Regex.IsMatch(text, @"^[a-zA-Z]+$")) {
            return null;
        }
        string changedText = string.Empty;
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        switch ((ChangeTypes)(type)) {
            case ChangeTypes.Upper:
                changedText = textInfo.ToUpper(text);
                break;
            case ChangeTypes.Lower:
                changedText = textInfo.ToLower(text);
                break;
        }
        return changedText;
    }
}
