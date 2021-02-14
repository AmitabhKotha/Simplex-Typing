using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] words = {"unhealthy","windy","cast","attention","bed","treatment","opine",
            "stimulating","sanction","art","pray","gaze","finish","adjust","toe","loaf","uninterested","scene",
        "determine","overjoyed","flock","glance","cub","measly","arrange","mark","leather","naive","gash","succinct","misuse","porter","grab",
        "cleave","input","implant","contribute","groovy","motivate","excited","abiding","fiction","colour","maintain",
        "statement","lead","speed","sacrifice","chance","bell","swim","destroy","symptomatic","incredible",
        "permissible","large","idolize","dine","car","nest","admire","flag","ran","stretch","numerous",
        "sleepy","hysterical","tired","fireman","rate","summer","pricey","goodbye","enchanting",
        "animate","vein","warn","farmer","progress","sally","wind","labor","evil","illumine","victorious",
        "unequal","last","illuminate","versed","forecast","powder","limp","zoo","spotty","laderely","hissing",
        "kid","recess","toy","jail","brick","son","development","ingest","slit","wind","pen","new","perpetual",
        "guilt","less","produce","tends","ink","petite","precious","seed","fang","salt","dinner","kindly","fixed",
        "level","process","lawyer","skillful","need","eleven","heavy","correct","dogs","fold","puzzling",
        "songs","pray","charming","imitate","new","cluttered","reminiscent","encircle","comforting","competent",
        "damp","twig","value","malicious","giant","channel","graceful","uneven","deranged","taste","less",
        "convict","general","towering","glue","adaptable","force","alarm","quicksand","endorse","likeable",
        "doctor","oven","oppress","vase","powder","straw","harsh","improve","bless","leech","watch",
        "flimsy","yawn","fly","beast","shaggy","refer","any","choose","infamous","steep","robust","pout",
        "classify","recondite","bash","sour","restrain","preach","heady","slay","medical","sentence",
        "magnificent","damp","mew","sew","ready","subtract","attend","glamorous","match","smite",
        "transport","mature","puffy","tasteless","drop","motionless","soft","business","perpetual","hate",
        "shy","page","gaping","scar","frequent","borish","wooden","movie","voice","lawyer","anxious",
        "uproot","import","thundering","elbowl","encroach","review","early","wear","top","sweater","flash",
        "conquer","pardon","record","screen","precious","zonked","mind","proud","spit","jump","grand",
        "inside","ink","hop","discussion","vegetables","leep","gold","sand","skid","minute","box",
        "finish","dramatic","unit","download","cork","pan","believe","battle","honorable","flat","window",
        "creep","cabbage","cloth","hear","screw","mood","stretch","plan","position","white","sock",
        "crush","fix","skinny","learning","certain","graceful","funny","star","coast","boat","goldfish",
        "love","respect","space","trees","respect","itchy"};
    //void start()
    //{

    //}
    //void update()
    //{

    //}
    public static string GetRandomWord()
    {
        int index = UnityEngine.Random.Range(0, words.Length);
        return words[index];
    }
}
