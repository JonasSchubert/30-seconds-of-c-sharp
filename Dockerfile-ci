FROM microsoft/dotnet:2.1-sdk

WORKDIR /src

COPY snippets/snippets.sln ./

COPY snippets/Date/*.csproj ./Date/
COPY snippets/Enumerable/*.csproj ./Enumerable/
COPY snippets/Math/*.csproj ./Math/
COPY snippets/Method/*.csproj ./Method/
COPY snippets/String/*.csproj ./String/
COPY snippets/Type/*.csproj ./Type/
COPY snippets/Utility/*.csproj ./Utility/

COPY snippets/Date.Test/*.csproj ./Date.Test/
COPY snippets/Enumerable.Test/*.csproj ./Enumerable.Test/
COPY snippets/Math.Test/*.csproj ./Math.Test/
COPY snippets/Method.Test/*.csproj ./Method.Test/
COPY snippets/String.Test/*.csproj ./String.Test/
COPY snippets/Type.Test/*.csproj ./Type.Test/
COPY snippets/Utility.Test/*.csproj ./Utility.Test/

RUN dotnet restore

COPY . .

RUN dotnet build
RUN dotnet test