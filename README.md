## NewUserRegistered

##### URL
```url
https://localhost:5001/message/register
```

##### METHOD
```method
POST
```

##### Payload - JSON
```json
{
    "MessageFormat" : 0, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F",
        "Email": "john.doe@gmail.com",
        "Firstname": "John",
        "Lastname": "Doe"
    }

}

```


##### Payload - CSV
```json
{
    "MessageFormat" : 1, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F",
        "Email": "john.doe@gmail.com",
        "Firstname": "John",
        "Lastname": "Doe"
    }

}

```


##### Payload - XML
```json
{
    "MessageFormat" : 2, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F",
        "Email": "john.doe@gmail.com",
        "Firstname": "John",
        "Lastname": "Doe"
    }

}

```

## UserDeleted

##### URL
```url
https://localhost:5001/message/delete
```

##### METHOD
```method
DELETE
```

##### Payload - JSON
```json
{
    "MessageFormat" : 0, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```


##### Payload - CSV
```json
{
    "MessageFormat" : 1, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```


##### Payload - XML
```json
{
    "MessageFormat" : 2, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```

## UserBlocked

##### URL
```url
https://localhost:5001/message/block
```

##### METHOD
```method
PUT
```

##### Payload - JSON
```json
{
    "MessageFormat" : 0, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```


##### Payload - CSV
```json
{
    "MessageFormat" : 1, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```


##### Payload - XML
```json
{
    "MessageFormat" : 2, 
    "MessageBody": {
        "UserId": "F334707D-ACD5-4F8B-98BC-CDB312D1210F"
    }
}

```
