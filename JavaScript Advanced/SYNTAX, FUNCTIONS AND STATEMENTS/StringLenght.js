function solve(first, second, third) {
    let a = first.length;
    let b = second.length;
    let c = third.length;

    let sum = a + b + c;

    console.log(sum);
    console.log(Math.floor(sum / 3));

    // function foo(...args) {
    //     const length = args.reduce((a, v) => a + v.length, 0)
    //     return `${length}
    // ${Math.round(length / args.length)}`
    // }
}
solve("chocolate", "ice cream", "cake");