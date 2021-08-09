# VUE-DOTNET/C# FullStack Application for Innova Systems International

## Project setup (CD root of files and:)
```
dotnet restore
```

### To run intial migrations (CD to root) Makefile provided
```
make migrations mname=Initial

make db

```

### To run the back end (CD to ItemReviews.Web:)
```
dotnet build && dotnet run
```

### To run the client (CD to client-vue directory and:)
```
npm install
npm run serve
```



