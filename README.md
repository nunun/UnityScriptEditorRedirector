UnityScriptEditorRedirector
===========================

Unity Editor for Windows では、[Edit] -> [Preferences] から
"External Script Editor" を設定したとしても、外部エディタを
行数引数付きで立ち上げることは出来ません。

そこで、このアプリを通して外部エディタを起動することにより、
外部エディタを任意の引数で立ち上げられるようにします。

Install
=======

下記リンクからインストーラ (.msi) をダウンロードして実行してください。

https://github.com/nunun/UnityScriptEditorRedirector/blob/master/UnityScriptEditorRedirectorSetup/Release/UnityScriptEditorRedirectorSetup.msi?raw=true

Configuration
=============

Unity Editor の Preferences から、外部エディタを
"Program Files/Unity Tools/UnityScriptEditorRedirector/monodevelop.exe" に
設定してください。

Unity からエディタを立ち上げるとき、UnityScriptEditorRedirector が起動して、
外部エディタにリダイレクトされます。

設定変更する場合は、デスクトップのショートカット、またはスタートメニューから
UnityScriptEditorRedirector を実行して下さい。

