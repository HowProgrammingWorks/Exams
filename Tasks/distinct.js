'use strict';

const distinct = (data) => Array.from(new Set(data));

const result = distinct([1, 2, 1, 3, 1, 4]);
console.log(result);
