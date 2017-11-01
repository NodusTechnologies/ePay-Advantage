EPay Advantage API Authentication
============================
Clients will always need to create a security token to authenticate with the EPay Advantage API. It is recommened to request a token for every API call to avoid any connection issue. However, the token will be valid for 5 minutes. All API calls made within that 5 minute timeframe can use the same token. Once it hits the 5 minute mark, it will become invalid and a new token will be needed.

##### Step 1: Get ClientID and Secret from EPay Advantage
This is located on your EPay Advantage website under Settings > ![Back Office Settings](https://github.com/NodusTechnologies/ePay-Advantage/blob/master/Sections/API%20Guide/Sections/APIs/Images/BackOfficeSettings.png)

##### Step 2: Convert Client ID and Secret into Base64
Combine the two values into a single string separated by a colon (:) character. Now, encode the string into [Base64](https://en.wikipedia.org/wiki/Base64)

##### Step 3: Generate Security Token
In the header for authorization, combine "Basic" with the base64 value

```shell
curl -X POST \
  http://epaypayfabric.supvpc7.nodus.com/6.0.1.022/API/Token \
  -H 'Authorization: Basic Y2xpZW50X2xxTTg0OXdSODhZM3hxZlJrWnByOmhKcTF4WldzdEgwdjNzbHdzQVBuenFBc2xiNkhzeXVtY3RDS1pRWm1ZL0M3NWRpRzR2' \
  -H 'content-type: application/x-www-form-urlencoded' \
  -d 'scope=EPayAPIServices&grant_type=client_credentials'
```
If the HTTP Status Code is 200 - OK, you will receive the following **JSON** response:

<pre>
{
  "access_token": "gAAAAJ60bU6-vW9_mcmGXz6BOjjBI8MSmjqg4OZHQcHr9xjTA-0ZL2bia2o_b6WYcD9YSoM4uARinCWN_nLuHoeF8uxvxtw2rNIl0RBDbvcQaofDpd9SuyzmVX3Xy9b0Yx7ngB81S3zjusrtgFnrUEThB4rhnMmeoVy1TQ7ePAKQVVQqFAEAAIAAAABJC95XyaM28bsDcbMZKY8faxCDo8spdvs1Debhq6nnqom25IcVzV2Jor0zze3NNAHMkvd8lOA_SEwFleWCTxCdED_PhjB19I3DE5tc3UTx6091lFtDngkAuHG4b7tcMud0Cxe9nv7bZ6l-RuP0ODDZeMjf99wd4m5mHKDeoz_hHc9tk3HUSp90fR-23iXNpYWBeNx-gEH-WyNjxFuw7nAywYZmDmdyGa1flVuD7M1rUwnG1QI3iEZ30TKDw7lcqycccksKADPPrGWX80hlAdAEZGDWCSTnjbzunmycASvyz_OJtj2gAt8DcRF7hLQmMxENLluYfMwqleOmOmiaCo1jBKk0f9BILb5k7gv2sxPj2Q",
  "token_type": "bearer",
  "expires_in": 600,
  "scope": "EPayAPIServices"
}
</pre>

##### Step 4: Using the Secruity Token
In the header for authorization, combine "Bearer" with the access token from the JSON response

```shell
curl -X GET \
  http://epaypayfabric.supvpc7.nodus.com/6.0.1.022/API/payment?status=1 \
  -H 'Authorization: Bearer gAAAAJ60bU6-vW9_mcmGXz6BOjjBI8MSmjqg4OZHQcHr9xjTA-0ZL2bia2o_b6WYcD9YSoM4uARinCWN_nLuHoeF8uxvxtw2rNIl0RBDbvcQaofDpd9SuyzmVX3Xy9b0Yx7ngB81S3zjusrtgFnrUEThB4rhnMmeoVy1TQ7ePAKQVVQqFAEAAIAAAABJC95XyaM28bsDcbMZKY8faxCDo8spdvs1Debhq6nnqom25IcVzV2Jor0zze3NNAHMkvd8lOA_SEwFleWCTxCdED_PhjB19I3DE5tc3UTx6091lFtDngkAuHG4b7tcMud0Cxe9nv7bZ6l-RuP0ODDZeMjf99wd4m5mHKDeoz_hHc9tk3HUSp90fR-23iXNpYWBeNx-gEH-WyNjxFuw7nAywYZmDmdyGa1flVuD7M1rUwnG1QI3iEZ30TKDw7lcqycccksKADPPrGWX80hlAdAEZGDWCSTnjbzunmycASvyz_OJtj2gAt8DcRF7hLQmMxENLluYfMwqleOmOmiaCo1jBKk0f9BILb5k7gv2sxPj2Q' \
```
