namespace Samantha.ECMSystemExport

module Config =
    open System.Collections.Generic
    type FileType = 
        | Yaml
        | Json

    let inline getFileTypeExtension filetype = 
        match filetype with
        | Yaml -> ".yml"
        | Json -> ".json"

    type FileConfig = 
        {
            Filename : string
            FileType : FileType
        }

    type SqlDialect = 
        | MSSQL
        | MySQL
        | PGSQL

    type SqlConfig =
        {
            Dialect : SqlDialect
            HostName : string
            Port : int
            DatabaseName : string
            AdditionalConfig : Dictionary<string, string>
        }
    
    module Import = 
        let importFromFile (config:FileConfig) = ()
    
    module Export =
        let exportToFile (config:FileConfig) = 
            match config.FileType with
            | Yaml -> 0
            | Json -> 1