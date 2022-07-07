function check(numbers) {
    let stringOfTheNumbers = numbers.toString();
    let check = true;
    let sum = Number(stringOfTheNumbers[0]);
    for (let i = 1; i < stringOfTheNumbers.length; i++) {
        if (stringOfTheNumbers[0] != stringOfTheNumbers[i]) {
            check = false;
        }
        sum += Number(stringOfTheNumbers[i]);
    }
    console.log(check);
    console.log(sum);

}

// function foo(n) {
//     const arr = `${n}`.split("")
//     return `${arr.every((x, i, arr1) => arr1.slice(i).every(y => x === y))}
// ${arr.map(Number).reduce((a, v) => a + v, 0)}`
// }

check(1234)