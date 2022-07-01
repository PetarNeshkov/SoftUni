function largestNumber(a, b, c) {
    let largestNumber;
    if (a > b && a > c) {
        largestNumber = a;
    }
    else if (b > a && b > c) {
        largestNumber = b;
    }
    else {
        largestNumber = c;
    }
    console.log(`The largest number is ${largestNumber}.`);

}
// function largestNum(...args) {
//     return `The largest number is ${args.sort((a, b) => b - a)[0]}.`
// }
largestNumber(5,-3,16);