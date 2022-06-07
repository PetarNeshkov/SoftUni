function Calculate(fruit,weight,price){
let weightToKg=weight/1000;
let totalPrice=weightToKg*price;
console.log(`I need $${totalPrice.toFixed(2)} to buy ${weightToKg.toFixed(2)} kilograms ${fruit}.`)
}
Calculate('orange', 2500, 1.80)