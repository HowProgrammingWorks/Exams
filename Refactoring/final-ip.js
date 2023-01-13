'use strict';

const Parseip = (ip) => {
  const Box = ip.split('.');
  if (Box.length !== 4) return;
  for (let k = 0; k < 4; k++) {
    if (isNaN(parseInt(Box[k]))) return;
    Box[k] = parseInt(Box[k]);
  }
  return Box;
};

require('../Tests/ip.js')(Parseip);