class BankAccount {
    depositorName: string;
    accountNumber: number;
    accountType: string;
    balance: number;

    constructor(name: string, accNo: number, type: string, balance: number) {
        this.depositorName = name;
        this.accountNumber = accNo;
        this.accountType = type;
        this.balance = balance;
    }

    deposit(amount: number): void {
        this.balance += amount;
        console.log("Deposited:", amount);
    }

    withdraw(amount: number): void {
        if (amount > this.balance) {
            console.log("Insufficient Balance!");
        } else {
            this.balance -= amount;
            console.log("Withdrawn:", amount);
        }
    }

    display(): void {
        console.log("Depositor:", this.depositorName);
        console.log("Balance:", this.balance);
    }
}

const acc = new BankAccount("Rahul", 12345, "Savings", 10000);
acc.deposit(2000);
acc.withdraw(5000);
acc.display();