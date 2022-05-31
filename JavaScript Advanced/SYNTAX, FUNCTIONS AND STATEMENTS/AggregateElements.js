function AggregateElements(arr) {
    let sum = 0;
    let inverseSum = 0;
    let concat = '';

    for (let i = 0; i < arr.length; i++) {
        sum += arr[i];;
        inverseSum += 1 / arr[i];;
        concat += arr[i].toString();
    }
    console.log(sum);
    console.log(inverseSum);
    console.log(concat);
}
AggregateElements([2, 4, 6, 8, 16])