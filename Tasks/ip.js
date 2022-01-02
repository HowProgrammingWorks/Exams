'use strict';

const parseIp = ip => ip === '' ? 0 : ip.split('.').map((e) => parseInt(e));

const result = parseIp('127.0.0.1');
console.dir(result);
