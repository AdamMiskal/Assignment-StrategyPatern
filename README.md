# Assignment-StrategyPatern

On this assignment you need to implement using the Strategy pattern the following scenario:

You have a product named T-Shirt[10 marks]that has three (3)variations, in terms of,
1.Color, {RED, ORANGE, YELLOW, GREEN, BLUE, INDIGO, VIOLET}
2.Size, {XS, S,M,L, XL, XXL, XXXL}
3.Fabric,  {WOOL, COTTON,  POLYESTER,  RAYON,  LINEN,  CASHMERE,  SILK}

Each variation gets a different price tag.
Also,each product can be paid via three (3) different payment methods,
1.Credit / Debit cards
2.Money / Bank Transfer
3.Cash

Construct a Strategy  pattern  that  implements  the  variations  and  the  payment methods  under  three  (3)  combined  strategies  that  implement  all  the  possible combinations as such:
1.Color, Size and Fabricwith Credit / Debit Cards
2.Color, Sizeand Fabricwith Money / Bank Transfer
3.Color, Size and Fabricwith Cash
