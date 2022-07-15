function sum(a, b) {
    let start=Number(a);
    let end=Number(b);
    let sum = 0;
    for (let i = start; i <= end; i++) {
        sum += i;
    }
   return sum;
}
console.log(sum('1','5'));
