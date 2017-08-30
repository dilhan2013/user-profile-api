# user-profile-api

Development In-Progress :)

Goal of this api is to provide user profile picture and full name based on email address or userid (a guid).

Details stored are;
* Email
* UserId
* FullName
* PhotoUrl

## Api endpoints

### Retriving profile information (use GET)
````
/profile/?email=sample@sample.com
/profile/?userId=44c6c3c4368a4e718e81e25bfa209cff
````
By default the api will return following details

````
FullName
PhotoUrl (default size is small 24x24px)
````

Photo sizes (small, medium, large, verylarge)
````
/profile/?email=sample@sample.com&photosize=small
/profile/?userId=44c6c3c4368a4e718e81e25bfa209cff&photosize=large
````


### Create/Update profile information (use POST)
````
/profile/

POST Data
{
    email: 'sample@sample.com',
    fullName: 'Sample Smith',
    userId: '44c6c3c4368a4e718e81e25bfa209cff',
    photoBase64Data: 'data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAASABIAAD.....'
}
````
Api will automatically generate different photo sizes based on the photo data uploaded. Use squire images for best results.

## Storage
MongoDB - Api will be using MongoDB for saving user profile data.
Azure Blob Storage - Api will be using Azure Blob Storage to store images.