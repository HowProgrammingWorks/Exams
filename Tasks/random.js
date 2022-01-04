// Generate random integer value in given range
'use strict';

const Random = (min, max) => {
    if (max === undefined){
        max = min;
        return Math.floor(Math.random() * (max + 1));
    }
    if (max === undefined && min === undefined) {
        return 'Data entered incorrectly.';
    }
    const random = min + Math.floor(Math.random() * (max - min + 1));
    return Math.floor(random);
};

const result = Random(1, 9);
console.log(result);
