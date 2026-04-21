"use strict";
class CreditCardPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    pay() {
        console.log(`Paid ${this.amount} using Credit Card`);
    }
    refund() {
        console.log("Refund initiated to Credit Card");
    }
}
class UPIPayment {
    amount;
    constructor(amount) {
        this.amount = amount;
    }
    pay() {
        console.log(`Paid ${this.amount} using UPI`);
    }
}
const cc = new CreditCardPayment(1000);
cc.pay();
cc.refund();
console.log("");
const upi = new UPIPayment(500);
upi.pay();
