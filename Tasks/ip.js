'use strict';

const Parseip = i => i === '' ? return 0 : return i.split('.').map((e) => parseInt(e));

const result = Parseip('127.0.0.1')
console.log(result)
