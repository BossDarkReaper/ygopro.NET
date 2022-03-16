﻿using Newtonsoft.Json;

namespace YGOPRO.Models;

public class Cards
{
    public List<Card> data { get; set; }
}

public class Card
{
    [JsonProperty("id")]
   public int Id { get; set; }
   
   [JsonProperty("name")]
   public string Name { get; set; }
   
   [JsonProperty("type")]
   public string Type { get; set; }
   
   [JsonProperty("desc")]
   public string Description { get; set; }
   
   [JsonProperty("atk")]
   public int Attack { get; set; }
   
   [JsonProperty("def")]
   public int Defense { get; set; }
   
   [JsonProperty("level")]
   public int Level { get; set; }
   
   [JsonProperty("race")]
   public string Race { get; set; }
   
   [JsonProperty("attribute")]
   public string Attribute { get; set; }
   
   [JsonProperty("archetype")]
   public string Archetype { get; set; }
   
   [JsonProperty("card_sets")]
   public List<CardSet> CardSets { get; set; }
}

public class CardSet
{
    [JsonProperty("set_name")]
    public string SetName { get; set; }
    
    [JsonProperty("set_code")]
    public string SetCode { get; set; }
    
    [JsonProperty("set_rarity")]
    public string SetRarity { get; set; }
    
    [JsonProperty("set_rarity_code")]
    public string SetRarityCode { get; set; }
    
    [JsonProperty("set_price")]
    public string SetPrice { get; set; }
}