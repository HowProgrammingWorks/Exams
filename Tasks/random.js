// Generate random integer value in given range
'use strict';

const generateRandom = (minValue, maxValue) => {
    if (maxValue === undefined){
        maxValue = minValue;
        return Math.floor(Math.random() * (maxValue + 1));
    }
    if (maxValue === undefined && minValue === undefined) {
        return 'Data entered incorrectly.';
    }
    const random = minValue + Math.floor(Math.random() * (maxValue - minValue + 1));
    return Math.floor(random);
};

const result = random(1, 9);
console.log(result);
