function greatestCommonDivisor(x,y){
    let divisor=0;
    let minNumber=Math.min(x,y);
    for (let index = 1; index <= minNumber; index++) {
        if (x%index==0 && y %index==0) {
            divisor=index;
        }
    }
    console.log(divisor);
}
greatestCommonDivisor(15,5);