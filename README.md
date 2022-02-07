# Discount-Calculator

The assignment mimics the basic operation of a Jewelry Store.
- The candidate is at free-will to implement the given assignment either as a console application or as a RESTful API application.
- The solution can be .Net/.NET Core and Database can be local DB / In memory


## Requirement:
</br>The description of the expected functionalities are as follows:
- **Login** - It allows users to login. The users can be stored in the database and the database can be local or in memory. It takes two mandatory parameters which are of string type - (i) Username (ii) Password
- **Calculate total price** - This method (or endpoint) will be protected. Until and unless the user has not logged-in, he/she should not be able to access this method (or endpoint).

It takes following parameters:

(i) Gold price (per gram) - This is a required parameter and accepts only numerical value, which contains the price of gold per gram.

(ii) Weight of the item (in grams) - This is a required parameter and accepts only numerical value, which contains the weight of the gold in grams.

(iii) Discount (in percentage) - This is an optional parameter and accepts only numerical value. It contains the discount percentage.

The method (or API endpoint in case of RESTful implementation) returns the total price based on the formula: (Gold price per gram * weight) - discount

**For Example:**

(1) Gold price = 1000
</br>Weight of the item (in grams) = 10
</br>Discount (in percentage) = NULL
</br>Thus, total price of the item => (1000 * 10) = 10000
			
(2)	Gold price = 1000
		</br>	Weight of the item (in grams) = 10
		</br>	Discount (in percentage) = 5
</br>Thus, total price of the item => (1000 * 10) - Discount = 10000 - (5% of 10000) = 9500

**Note:**
No need for any registration of user. By default, you can store the users in local DB/in memory.

## Expectations:
- The candidate is at free-will to implement the given assignment either as a console application or as a RESTful API application.
- Please use best practices everywhere.
- Unit tests are mandatory to be wirtten.
- In case of RESTful API application, swagger documentation is not mandatory, but if provided, it would be helpful.
