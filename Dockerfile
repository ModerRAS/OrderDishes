FROM mcr.microsoft.com/dotnet/aspnet:8.0

RUN sed -i 's/http:\/\/deb.debian.org/https:\/\/mirrors.tuna.tsinghua.edu.cn/g' /etc/apt/sources.list

RUN apt update -y && \
    apt install -y fontconfig && \
    apt-get install -y --allow-unauthenticated \
        libc6-dev \
        libgdiplus \
        libx11-dev \
     && rm -rf /var/lib/apt/lists/*


WORKDIR /app

COPY ./out /app

ENTRYPOINT ["dotnet", "OrderDishes.dll"]
