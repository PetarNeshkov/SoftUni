function CircleArea(input) {
    let result=0;
    if (typeof (input) == 'number') {
        return result = (Math.pow(input,2) * Math.PI).toFixed(2);
    }
    else{
        return (`We can not calculate the circle area, because we receive a ${typeof(input)}.`);
    }
}
console.log(CircleArea(5));