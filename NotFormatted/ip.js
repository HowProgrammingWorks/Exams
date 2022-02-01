// Split string by the first occurrence of separator

Parseip = i => {
  a = []
    if (i === '' ) return 0  ;
  else {
  B = i.split('.');
  j = 0
    for ( const b of B) {
  a[j] = parseInt(b);
  j++;
  }};
  return a;
};

require('../Tests/ip.js')(Parseip);
