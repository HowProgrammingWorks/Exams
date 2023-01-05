// 'use strict';
// rename

'use strict';

const Parseip = (ip) => {
  const a = [];
  if (ip === '') return;
  else {
    const B = ip.split('.');
    if (B.length != 4) return;
    let j = 0;
    for (const b of B) {
      a[j] = parseInt(b);
      if (isNaN(a[j])) return;
      j++;
    }
  }
  return a;
};

require('../Tests/ip.js')(Parseip);