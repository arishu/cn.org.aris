@echo off
REM "get administrator permission"
REM %1 mshta vbscript:CreateObject("Shell.Application").ShellExecute("cmd.exe","/c %~s0 ::","","runas",1)(window.close)&&exit


explorer /select, "%USERPROFILE%\AppData\Local\Temp\aris.org.cn\json\jackson\json-example\logging.log"