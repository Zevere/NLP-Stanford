FROM       mono:5.8.0.127
WORKDIR    /app
COPY       . .
RUN        nuget restore
RUN        msbuild StanfordNLP.sln /t:Build /p:Configuration=Release
CMD        [ "mono", "StanfordNLP/bin/Release/StanfordNLP.exe" ]