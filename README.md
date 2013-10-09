UnityScriptEditorRedirector
===========================

Unity Editor for Windows では、[Edit] -> [Preferences] から
"External Script Editor" を設定したとしても、外部エディタを
行数引数付きで立ち上げることは出来ません。

そこで、このアプリをと押して外部エディタを起動することにより、
外部エディタを任意の引数で立ち上げられるようにします。

Install
=======

Unity Editor の Preferences から、外部エディタをこのパッケージに
含まれる "monodevelop.exe" に設定してください。

Unity からエディタを立ち上げるとき、UnityScriptEditorRedirector が
起動して、外部エディタへのリダイレクト設定画面が表示されます。

一度設定が終わると設定画面は表示されなくなりますが、
再度設定変更を行ないたい場合は、"monodevelop.exe" を直接
ダブルクリックして起動して下さい。

