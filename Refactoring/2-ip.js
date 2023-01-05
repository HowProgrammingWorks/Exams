// remove {}
// remove 'a' and rename B -> Box

'use strict';

const Parseip = (ip) => {
  if (ip === '') return;

  const Box = ip.split('.');
  if (Box.length != 4) return;
  let j = 0;
  for (const b of Box) {
    Box[j] = parseInt(b);
    if (isNaN(Box[j])) return;
    j++;
  }
  return Box;
};

require('../Tests/ip.js')(Parseip);