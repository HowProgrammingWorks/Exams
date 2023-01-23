const getvaluebetween = (Imput_Word, Imput_Prefix,Imput_Suffix) => {
const Word = Imput_Word;
const Prefix = Imput_Prefix;
const Suffix = Imput_Suffix;
const IndexPrefixInWord = Word.indexOf(Prefix);
if (IndexPrefixInWord == -1) return;
const IndexSuffixInWord = Word.indexOf(Suffix);
if (IndexSuffixInWord == -1) return;
const AmountCharInPrefix = Prefix.length;
const EndIndexCharInPrefix = IndexPrefixInWord + AmountCharInPrefix;
const SubstringBetweenPrefixAndSuffix = Word.substring(EndIndexCharInPrefix, IndexSuffixInWord);
console.log(`Substring between prefix and suffix: ${SubstringBetweenPrefixAndSuffix}`);
return;
}
const between_js =  getvaluebetween ('different','di','en');