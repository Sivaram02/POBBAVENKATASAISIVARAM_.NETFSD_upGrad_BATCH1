interface Payment {
    amount: number;
    pay(): void;
}

interface Refundable {
    refund(): void;
}

class CreditCardPayment implements Payment, Refundable {
    amount: number;

    constructor(amount: number) {
        this.amount = amount;
    }

    pay(): void {
        console.log(`Paid ${this.amount} using Credit Card`);
    }

    refund(): void {
        console.log("Refund initiated to Credit Card");
    }
}

class UPIPayment implements Payment {
    amount: number;

    constructor(amount: number) {
        this.amount = amount;
    }

    pay(): void {
        console.log(`Paid ${this.amount} using UPI`);
    }
}

const cc = new CreditCardPayment(1000);
cc.pay();
cc.refund();

console.log(""); 

const upi = new UPIPayment(500);
upi.pay();