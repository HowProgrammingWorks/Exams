'use strict';

const parseIp = (ip) => {
  if (ip !== '') {
    const arr = ip.split('.');
    return arr.map((element) => parseInt(element));
  }
  return 0;
};
