'use strict';

const parseIp = (ip) => ip === '' ? 0 : ip.split('.').map((e) => parseInt(e));
