﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using ShellFiler.Api;
using ShellFiler.Document;
using ShellFiler.FileSystem;
using ShellFiler.Util;
using ShellFiler.UI;

namespace ShellFiler.Archive {

    //=========================================================================================
    // クラス：ファイルの一覧取得を行うインターフェース
    //=========================================================================================
    public interface IArchiveExtract {

        //=========================================================================================
        // 機　能：破棄する
        // 引　数：なし
        // 戻り値：なし
        //=========================================================================================
        void Dispose();
        
        //=========================================================================================
        // 機　能：アーカイブファイルを開く
        // 引　数：[in]progress  進捗情報表示用のインターフェース
        // 戻り値：ステータス
        //=========================================================================================
        FileOperationStatus Open(FileProgressEventHandler progress);

        //=========================================================================================
        // 機　能：アーカイブ内のファイルとフォルダの数を返す
        // 引　数：なし
        // 戻り値：ファイルとフォルダの数
        //=========================================================================================
        int GetFileCount();
        
        //=========================================================================================
        // 機　能：アーカイブ内のルートディレクトリがユニークな場合にルートディレクトリ名を返す
        // 引　数：なし
        // 戻り値：ルートディレクトリ名（一意ではない場合null）
        //=========================================================================================
        string GetRootFileNameIfUnique();

        //=========================================================================================
        // 機　能：ファイル情報を返す
        // 引　数：[in]index  取得するインデックス
        // 戻り値：ファイル情報
        //=========================================================================================
        IArchiveContentsFileInfo GetFileInfo(int index);

        //=========================================================================================
        // 機　能：ファイルを展開する
        // 引　数：[in]fileInfo  展開するファイルの情報
        // 　　　　[in]destPath  対象ディレクトリのパス（最後はセパレータ）
        // 　　　　[in]overwrite 上書きする場合true
        // 　　　　[in]progress  進捗情報表示用のインターフェース
        // 戻り値：ファイル情報
        //=========================================================================================
        FileOperationStatus Extract(IArchiveContentsFileInfo fileInfo, string destPath, bool overwrite, FileProgressEventHandler progress);

        //=========================================================================================
        // プロパティ：アーカイブファイル名
        //=========================================================================================
        string ArchiveFileName {
            get;
        }

        //=========================================================================================
        // プロパティ：使用したパスワードに対応する表示名（パスワードが自動入力でないときはnull）
        //=========================================================================================
        string UsedPasswordDisplayName {
            get;
        }
    }
}