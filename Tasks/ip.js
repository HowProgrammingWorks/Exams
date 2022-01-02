'use strict';

const parseIp = ip => ip === '' ? return 0 : return ip.split('.').map((e) => parseInt(e));

const result = parseIp('127.0.0.1');
console.dir(result);
