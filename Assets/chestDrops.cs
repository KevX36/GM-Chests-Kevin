using UnityEngine;

public class chestDrops : MonoBehaviour
{
    
    public int woodDropRate = 5;
    public int bronzeDropRate = 4;
    public int sliverDropRate = 3;
    public int goldDropRate = 2;
    public int platnumDropRate = 1;
    private int chestTotal;

    public int woodCommon = 5;
    public int woodUncommon = 4;
    public int woodRare = 3;
    public int woodEpic = 2;
    public int woodLegend = 1;
    private int woodTotal;

    public int bronzeCommon=5;
    public int bronzeUncommon=4;
    public int bronzeRare=3;
    public int bronzeEpic=2;
    public int bronzeLegend=1;
    private int bronzeTotal;

    public int sliverCommon=5;
    public int sliverUncommon=4;
    public int sliverRare=3;
    public int sliverEpic=2;
    public int sliverLegend=1;
    private int sliverTotal;

    public int goldCommon=5;
    public int goldUncommon=4;
    public int goldRare=3;
    public int goldEpic=2;
    public int goldLegend=1;
    private int goldTotal;

    public int platnumCommon=5;
    public int platnumUncommon=4;
    public int platnumRare=3;
    public int platnumEpic=2;
    public int platnumLegend=1;
    private int platnumTotal;

    public GameObject woodChest;
    public GameObject bronzeChest;
    public GameObject sliverChest;
    public GameObject goldChest;
    public GameObject platnumChest;

    public GameObject commonItem;
    public GameObject uncommonItem;
    public GameObject rareItem;
    public GameObject epicItem;
    public GameObject legendItem;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //setting totals
        chestTotal = woodDropRate + bronzeDropRate + sliverDropRate + goldDropRate + platnumDropRate;
        woodTotal = woodCommon + woodUncommon + woodRare + woodEpic + woodLegend;
        bronzeTotal = bronzeCommon + bronzeUncommon + bronzeRare + bronzeEpic + bronzeLegend;
        sliverTotal = sliverCommon + sliverUncommon + sliverRare + sliverEpic + sliverLegend;
        goldTotal = goldCommon + goldUncommon + goldRare + goldEpic + goldLegend;
        platnumTotal = platnumCommon + platnumUncommon + platnumRare + platnumEpic + platnumLegend;
        //setting chests as inactive
        woodChest.gameObject.SetActive(false);
        bronzeChest.gameObject.SetActive(false);
        sliverChest.gameObject.SetActive(false);
        goldChest.gameObject.SetActive(false);
        platnumChest.gameObject.SetActive(false);
        //setting items as inactive
        commonItem.gameObject.SetActive(false);
        uncommonItem.gameObject.SetActive(false);
        rareItem.gameObject.SetActive(false);
        epicItem.gameObject.SetActive(false);
        legendItem.gameObject.SetActive(false);






    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //setting chests as inactive
            woodChest.gameObject.SetActive(false);
            bronzeChest.gameObject.SetActive(false);
            sliverChest.gameObject.SetActive(false);
            goldChest.gameObject.SetActive(false);
            platnumChest.gameObject.SetActive(false);
            //setting items as inactive
            commonItem.gameObject.SetActive(false);
            uncommonItem.gameObject.SetActive(false);
            rareItem.gameObject.SetActive(false);
            epicItem.gameObject.SetActive(false);
            legendItem.gameObject.SetActive(false);
            int chestRoll = Random.Range(1, chestTotal);
            if (chestRoll <= woodDropRate)
            {
                int itemRoll = Random.Range(1, woodTotal);
                woodChest.gameObject.SetActive(true);
                if (itemRoll <= woodCommon)
                {
                    commonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= woodCommon + woodUncommon)
                {
                    uncommonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= woodCommon + woodUncommon+woodRare)
                {
                    rareItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= woodCommon + woodUncommon + woodRare+woodEpic)
                {
                    epicItem.gameObject.SetActive(true);
                }
                else
                {
                    legendItem.gameObject.SetActive(true);
                }








            }
            else if (chestRoll <= woodDropRate +bronzeDropRate)
            {
                int itemRoll = Random.Range(1, bronzeTotal);
                bronzeChest.gameObject.SetActive(true);
                if (itemRoll <= bronzeCommon)
                {
                    commonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= bronzeCommon + bronzeUncommon)
                {
                    uncommonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= bronzeCommon + bronzeUncommon + bronzeRare)
                {
                    rareItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= bronzeCommon + bronzeUncommon + bronzeRare + bronzeEpic)
                {
                    epicItem.gameObject.SetActive(true);
                }
                else
                {
                    legendItem.gameObject.SetActive(true);
                }
            }
            else if (chestRoll <= woodDropRate + bronzeDropRate+sliverDropRate)
            {
                int itemRoll = Random.Range(1, sliverTotal);
                sliverChest.gameObject.SetActive(true);
                if (itemRoll <= sliverCommon)
                {
                    commonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= sliverCommon + sliverUncommon)
                {
                    uncommonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= sliverCommon + sliverUncommon + sliverRare)
                {
                    rareItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= sliverCommon + sliverUncommon + sliverRare + sliverEpic)
                {
                    epicItem.gameObject.SetActive(true);
                }
                else
                {
                    legendItem.gameObject.SetActive(true);
                }
            }
            else if (chestRoll <= woodDropRate + bronzeDropRate + sliverDropRate+goldDropRate)
            {
                int itemRoll = Random.Range(1, goldTotal);
                goldChest.gameObject.SetActive(true);
                if (itemRoll <= goldCommon)
                {
                    commonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= goldCommon + goldUncommon)
                {
                    uncommonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= goldCommon + goldUncommon + goldRare)
                {
                    rareItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= goldCommon + goldUncommon + goldRare + goldEpic)
                {
                    epicItem.gameObject.SetActive(true);
                }
                else
                {
                    legendItem.gameObject.SetActive(true);
                }
            }
            else
            {
                int itemRoll = Random.Range(1, platnumTotal);
                platnumChest.gameObject.SetActive(true);
                if (itemRoll <= platnumCommon)
                {
                    commonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= platnumCommon + platnumUncommon)
                {
                    uncommonItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= platnumCommon + platnumUncommon + platnumRare)
                {
                    rareItem.gameObject.SetActive(true);
                }
                else if (itemRoll <= platnumCommon + platnumUncommon + platnumRare + platnumEpic)
                {
                    epicItem.gameObject.SetActive(true);
                }
                else
                {
                    legendItem.gameObject.SetActive(true);
                }
            }















        }
    }
}
