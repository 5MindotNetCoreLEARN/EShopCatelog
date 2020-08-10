## Add New Item
curl --location --request POST 'https://localhost:44305/api/v1/Add' \    
--header 'Content-Type: application/json' \    
--data-raw '{    
    "Name": "Galaxy Note 20",    
    "Description": "512 GB",    
    "Price": 45,    
    "PictureFileName": "note20",    
    "PictureUri": "http://samsung.com/note20",    
    "AvailableStock": 5    
}'    
    
## GetCatalog Items endpoint
curl --location --request GET 'https://localhost:44305/api/v1/GetCatalog'
