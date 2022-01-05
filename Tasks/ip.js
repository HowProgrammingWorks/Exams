// Split string by the first occurrence of separator

Parseip = i => {
  a = []
    if (i === '' ) return 0  ;
  else {
  B = i.split('.');
    for (let j=0; j<B.length; j++) {
  a[j] = parseInt(B[j]);
  }};
  return a;
};

const result = Parseip('127.0.0.1')
console.log(result)
