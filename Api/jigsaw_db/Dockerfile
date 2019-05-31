FROM mcr.microsoft.com/mssql-tools
COPY ./CreateDatabase .

RUN /opt/mssql-tools/bin/sqlcmd -i CreateDatabase.sql