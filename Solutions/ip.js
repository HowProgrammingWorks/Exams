// Test file for 'ip' is modified    [['10.0.zero.10'], undefined]
'use strict';

const Parseip = (ip) => {
  const Box = ip.split('.'); 
  for(let k = 0; k < 4; k++){
    if(isNaN(parseInt(Box[k]))) return;
    Box[k] = parseInt(Box[k]);
  }
  return Box;
}
require('../Tests/ip.js')(Parseip);