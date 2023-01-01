'use stirct';
// Extract substring between prefix and suffix

const getvaluebetween = (str, p, s) =>
  str.slice(
    str.indexOf(p) + 1 || str.length,
    s && str.indexOf(s) + 1 && str.indexOf(s)
  );

require('../Tests/between.js')(getvaluebetween);
