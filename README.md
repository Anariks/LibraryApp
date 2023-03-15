# Simple ASP.NET Web Api Library

Hello! Here is little application with simple library model. 
I used here layered architecture to separate different parts of the app. 

What did I use and implement here?

	- Entity Framework Core with in-memory database. 
	- Fluent validator to validate incomming objects
	- Middleware request logging
	- Middleware error handling
	- Custom Exceptions
	- Explicity/Implicity methods to transform models to/from DTO instead of using automapper
	- Seeding initial data for Database
	- Hybrid Model Binding <https://www.nuget.org/packages/HybridModelBinding/0.18.1-alpha.5>


Here is what you can do with it:

##### 1. Get all books. Order by provided value (title or author)
`GET https://{{baseUrl}}/api/books?order=author`


 ```json
 //Response:
 [{
 	"id": "number",    
 	"reviewsNumber": "number",    	//count of reviews
 	"title": "string",
 	"author": "string",
 	"rating": "decimal",          	//average rating
 }]
 ```

##### 2. Get top 10 books with high rating and number of reviews greater than 10. You can filter books by specifying genre. Order by rating
`GET https://{{baseUrl}}/api/recommended?genre=fantasy`
```json
//Response
 [{
 	"id": "number",
 	"title": "string",
 	"author": "string",
 	"rating": "decimal",          	//average rating
 	"reviewsNumber": "number"    	//count of reviews
 }]
```
##### 3. Get book details with the list of reviews
`GET https://{{baseUrl}}/api/books/{id}`
```json
//Response
 {
 	"id": "number",
 	"title": "string",
 	"author": "string",
 	"cover": "string",
 	"content": "string",
 	"rating": "decimal",          	//average rating
 	"reviews": [{
     	    "id": "number",
     	    "message": "string",
     	    "reviewer": "string",
 	}]
 }
 ```
##### 4. Delete a book using a secret key. Secret key is in appsettings.
`DELETE https://{{baseUrl}}/api/books/{id}?secret=qwerty`

##### 5. Save a new book.
`POST https://{{baseUrl}}/api/books/save`

```json
{
	"id": "number",             	// if id is not provided creates a new book, otherwise - updates an existing one
	"title": "string",
	"cover": "string",          	// base64 image, but in reality just a dummy stirng))
	"content": "string",
	"genre": "string",
	"author": "string"
}

// Response
 {
	"id": "number"
 }
 ```
##### 6. Save a review for the book.
`PUT https://{{baseUrl}}/api/books/{id}/review`
```json
{
	"message": "string",
	"reviewer": "string",
}

//Response
 {
 	"id": "number"
 }
 ```

##### 7. Rate a book
`PUT https://{{baseUrl}}/api/books/{id}/rate`

```json
 {
 	"score": "number"    	// score can be from 1 to 5
 }
 ```



