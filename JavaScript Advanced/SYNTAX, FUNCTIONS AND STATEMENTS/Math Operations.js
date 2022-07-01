function operation(a, b, command) {
    var sum = 0;
    switch (command) {
        case "+":
            sum = a + b;
            break;
        case "-":
            sum = a - b;
            break;
        case "*":
            sum = a * b;
            break;
        case "/":
            sum = a / b;
            break;
        case "%":
            sum = a % b;
            break;
        case "**":
            sum = a ** b;
            break;
    }
    console.log(sum);
}
operation(5, 6, '+');