// lab 1: Account.h
// Definition of Account class.
class Account
{
public:
	Account(int);
	void credit(int);
	void debit(int);
	int getBalance();
private:
	int balance;
}; 
