function solve(steps, stepsLength, speed) {
    let distanceInMeters = steps * stepsLength;
    let speedForMeterInSec = speed / 3.6;

    let rest = Math.floor(distanceInMeters / 500);
    let timeInSeconds = distanceInMeters / speedForMeterInSec + rest * 60;

    let timeInHours = Math.floor(timeInSeconds / 3600);
    let timeInMins = Math.floor(timeInSeconds / 60);
    let timeInSecs = Math.round(timeInSeconds % 60);

    console.log(`${pad(timeInHours)}:${pad(timeInMins)}:${pad(timeInSecs)}`);

    function pad(num) {
        if (num < 10) {
            return '0' + num;
        } else {
            return '' + num;
        }
    }
}
solve(4000, 0.60, 5);