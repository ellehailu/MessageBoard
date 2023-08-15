# API Documentation: MessageBoard

## Getting started

**Description:** Welcome to MessageBoardAPI. This API provides endponts to manage messages within the message board system. You can access, create, update and delete messages.

**Supported binding**
Currently we support the following client binding

- C#
  `"https://localhost:2001/api/Messages/"`
- JavaScript
  `"https://localhost:2001/api/Messages"`

#### Endpoints

1. **GET: api/Messages**

   - **Description:** Retrieve a list of messages based on specified filters.
   - **Query Parameters:**
     - `subject` (string): Filter messages by containing the specified subject.
     - `body` (string): Filter messages by containing the specified body text.
     - `group` (string): Filter messages by containing the specified group.
   - **Returns:** List of `Message` objects matching the filters.

2. **GET: api/Messages/{id}**

   - **Description:** Retrieve a specific message by its ID.
   - **Path Parameters:**
   - `id` (int): ID of the message to retrieve.
   - **Returns:**
   - 200 OK with `Message` object: If the message is found.
   - 404 Not Found: If the message with the given ID does not exist.

3. **PUT: api/Messages/{id}**

   - **Description:** Update an existing message.
   - **Path Parameters:**
     - `id` (int): ID of the message to update.
   - **Request Body:** `Message` object with updated fields.
   - **Returns:**
     - 204 No Content: If the update is successful.
     - 400 Bad Request: If the provided ID does not match the message ID.
     - 404 Not Found: If the message with the given ID does not exist.

4. **POST: api/Messages**

   - **Description:** Create a new message.
   - **Request Body:** `Message` object with required fields.
   - **Returns:**
     - 201 Created: If the message is successfully created. Returns the created message in the response body.
     - 400 Bad Request: If the provided message object is invalid.

5. **DELETE: api/Messages/{id}**

   - **Description:** Delete a message by its ID.
   - **Path Parameters:**
     - `id` (int): ID of the message to delete.
   - **Returns:**
     - 204 No Content: If the message is successfully deleted.
     - 404 Not Found: If the message with the given ID does not exist.
