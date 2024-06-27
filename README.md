# Shopping Cart GraphQL application

This application is designed to manage books, categories and orders efficiently. It leverages GraphQL query language for defining APIs and handling data operations. Th application provides functionalities for creating,reading, updating and deleting records related to books, categories and orders.

# Entity framework ORM Data migration

```
Add-Migration init
update-database
```

# Test Cases

Get all books

```
query{
  bookQuery{
    books{
      id
      title
      price
      author
      imageUrl
      categoryId
    }
  }
}
```

Get book by Id

```
query GetBookById($bookId: Int!) {
  bookQuery {
    book(bookId: $bookId) {
      id
      title
      price
      author
      imageUrl
      categoryId
    }
  }
}

# variables
{
  "bookId": 1
}
```

Add book

```
mutation AddBook($book:  BookInputType){
  bookMutation{
    createBook(book:$book){
      id
      title
      author
      price
      imageUrl
      categoryId
    }
  }
}
#variables
{
  "book": {
    "title": "aa",
    "author": "aa",
    "price": 10,
    "imageUrl": "https://example.com/categories/fiction.jpg",
    "categoryId": 1
  }
}
```

Update Book

```
mutation UpdateBook($bookId:Int $book:  BookInputType){
  bookMutation{
    updateBook(bookId:$bookId, book:$book){
      id
      title
      author
      price
      imageUrl
      categoryId
    }
  }
}
# variables
{
  "bookId": 4,
  "book": {
    "title": "aa1",
    "author": "bb1",
    "price": 12
  }
}
```

Delete book

```
mutation DeleteBook($bookId:Int){
  bookMutation{
    deleteBook(bookId:$bookId)
  }
}
#variables
{
  "bookId": 4
}
```

# Category

```
query{
  categoryQuery {
    categories {
      id
      name
      imageUrl
      books{
        id
        title
        price
        author
        imageUrl
        categoryId
      }
    }
  }
}
```

create category

```
mutation AddCategory($category: CategoryInputType){
  categoryMutation{
    createCategory(category:$category){
      id
      name
      imageUrl
      books{
        id
        title
        price
        author
        imageUrl
        categoryId
      }
    }
  }
}
#variables
{
  "category": {
    "name": "aa",
    "imageUrl": "https://example.com/categories/aa.jpg"
  }
}
```

update category

```
mutation UpdateCategory($categoryId:Int $category: CategoryInputType){
  categoryMutation{
    updateCategory(categoryId:$categoryId,category:$category){
      id
      name
      imageUrl
    }
  }
}
#variables
{
  "categoryId": 4,
  "category": {
    "name": "aa1",
    "imageUrl": "https://example.com/categories/aa1.jpg"
  }
}
```

delete category

```
mutation DeleteCategory($categoryId:Int){
  categoryMutation{
    deleteCategory(categoryId:$categoryId)
  }
}
#variables
{
  "categoryId": 4
}
```

# Order

```
query{
  orderQuery {
    orders {
      id
      customerName
      email
      phoneNumber
      quantity
      specialRequest
      orderDate
    }
  }
}
```

create order

```
mutation AddOrder($order: OrderInputType){
  orderMutation{
    createOrder(order:$order){
      id
      customerName
      email
      phoneNumber
      quantity
      specialRequest
      orderDate
    }
  }
}
#variable
{
  "order": {
    "customerName": "aa",
    "email": "evebroaawn@example.com",
    "phoneNumber": "555-789-0123",
    "quantity": 4,
    "specialRequest": "aa",
    "orderDate": "2024-04-21"

  }
}
```
