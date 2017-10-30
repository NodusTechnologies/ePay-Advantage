## Term Discount
Term discount object represents a discount to be applied to an invoice if it is paid within the term alloted. This object will be included as a child attribute of other JSON objects (such as [Invoice](Invoice.md) and [Return](Return.md)).

| Attribute | Data Type | Definition | Max Length |
| :----------- | :--------- | :--------- | :--------- |
| DiscardDate\* | String | Timestamp indicating when this discount should be discarded. Format should be "YYYY-MM-DD" or "YYYY-MM-DD HH:mm:ss" | datetime |
| DiscountAvaialableAmount | Decimal | Available discount amount | decimal(19,5) |
\*Required
