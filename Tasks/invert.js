// Reverse dict, exchange key and value
'use strict';

const invertArray = (array) => {
    const invertedArray = Object.keys(array);
    for (const index of invertedArray) invertedArray[index] = array.pop();
    return invertedArray;
};

const result = invertArray([100, 200, 300, 400]);
console.log(result);