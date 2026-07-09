using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace v1.model
{
    public record Char_Info_Record
    {
        [JsonPropertyName("name")]
        public string name { get; init; } = "unknown";
        [JsonPropertyName("displayname")]
        public string display_name { get; init; } = "unknown";
        [JsonPropertyName("lifebarname")]
        public string life_bar_name { get; init; } = "unknown";
        [JsonPropertyName("versiondate")]
        public string version_date { get; init; } = "unknown";
        [JsonPropertyName("mugenversion")]
        public string mugen_version { get; init; } = "unknown";
        [JsonPropertyName("ikemenversion")]
        public string ikemen_version { get; init; } = "unknown";
        [JsonPropertyName("author")]
        public string author { get; init; } = "unknown";
        [JsonPropertyName("Pal.Defaults")]
        public List<int> pal_defaults { get; init; } = []; 
        [JsonPropertyName("potraitscale")]
        public float portrait_scale { get; init; } = 0;
        [JsonPropertyName("localcoord")]
        public Coordinate_Struct local_coord { get; init; } = default;
    }

    public record Char_Data_Record
    {
        [JsonPropertyName("life")]
        public int life { get; init; } = 0;
        [JsonPropertyName("power")]
        public int power { get; init; } = 0;
        [JsonPropertyName("attack")]
        public int attack { get; init; } = 0;
        [JsonPropertyName("defence")]
        public int defence { get; init; } = 0;
        [JsonPropertyName("liedown.time")]
        public int liedown_time { get; init; } = 0;
        [JsonPropertyName("airjuggle")]
        public int air_juggle { get; init; } = 0;
        [JsonPropertyName("volume")]
        public int volume { get; init; } = 0;
    }

    public record Char_Size_Record
    {
        [JsonPropertyName("xscale")]
        public float x_scale { get; init; } = 0;
        [JsonPropertyName("yscale")]
        public float y_scale { get; init; } = 0;
        [JsonPropertyName("ground.back")]
        public int ground_back { get; init; } = 0;
        [JsonPropertyName("ground.front")]
        public int ground_front { get; init; } = 0;
        [JsonPropertyName("air.back")]
        public int air_back { get; init; } = 0;
        [JsonPropertyName("air.front")]
        public int air_front { get; init; } = 0;
        [JsonPropertyName("height")]
        public int height { get; init; } = 0;
        [JsonPropertyName("height.crouch")]
        public int height_crouch { get; init; } = 0;
        [JsonPropertyName("height.air")]
        public Coordinate_Struct height_air { get; init; } = default;
        [JsonPropertyName("height.down")]
        public int height_down { get; init; } = 0;
        [JsonPropertyName("head.pos")]
        public Coordinate_Struct head_pos { get; init; } = default;
        [JsonPropertyName("mid.pos")]
        public Coordinate_Struct mid_pos { get; init; } = default;
        [JsonPropertyName("draw.offset")]
        public Coordinate_Struct draw_offset { get; init; }  = default;
    }

    public record Char_Velocity_Record
    {
        [JsonPropertyName("walk.fwd")]
        public float walk_fwd { get; init; } = 0;
        [JsonPropertyName("walk.back")]
        public float walk_back { get; init; } = 0;
        [JsonPropertyName("run.fwd")]
        public float run_fwd { get; init; } = 0;
        [JsonPropertyName("run.back")]
        public Coordinate_Struct run_back { get; init; } = default;
        [JsonPropertyName("jump.neu")]
        public Coordinate_Struct jump_neu { get; init; } = default;
        [JsonPropertyName("jump.back")]
        public float jump_back { get; init; } = 0;
        [JsonPropertyName("jump.fwd")]
        public float jump_fwd { get; init; } = 0;
        [JsonPropertyName("runjump.back")]
        public Coordinate_Struct run_jump_back { get; init; } = default;
        [JsonPropertyName("runjump.fwd")]
        public Coordinate_Struct run_jump_fwd { get; init; } = default;
        [JsonPropertyName("runjump.neu")]
        public Coordinate_Struct run_jump_neu { get; init; } = default;
        [JsonPropertyName("air.gethit.groundrecover")]
        public Coordinate_Struct air_get_hit_ground_recover { get; init; } = default;
        [JsonPropertyName("air.gethit.airrecover.mul")]
        public Coordinate_Struct air_get_hit_air_recover_mul { get; init; } = default;
        [JsonPropertyName("air.gethit.airrecover.add")]
        public float air_get_hit_air_recover_add { get; init; } = 0;
        [JsonPropertyName("air.gethit.airrecover.back")]
        public float air_get_hit_air_recover_back { get; init; } = 0;
        [JsonPropertyName("air.gethit.airrecover.fwd")]
        public float air_get_hit_air_recover_fwd { get; init; } = 0;
        [JsonPropertyName("air.gethit.airrecover.up")]
        public float air_get_hit_air_recover_up { get; init; } = 0;
        [JsonPropertyName("air.gethit.airrecover.down")]
        public float air_get_hit_air_recover_down { get; init; } = 0;
    }

    public record Char_Movement_Record
    {
        [JsonPropertyName("airjump.num")]
        public int air_jump_num { get; init; } = 0;
        [JsonPropertyName("airjump.height")]
        public float air_jump_height { get; init; } = 0;
        [JsonPropertyName("yaccel")]
        public float yaccel { get; init; } = 0;
        [JsonPropertyName("stand.friction")]
        public float stand_friction { get; init; } = 0;
        [JsonPropertyName("crouch.friction")]
        public float crouch_friction { get; init; } = 0;
        [JsonPropertyName("air.gethit.groundlevel")]
        public float air_get_hit_ground_level { get; init; } = 0;
        [JsonPropertyName("down.bounce.yaccel")]
        public float down_bounce_yaccel { get; init; } = 0;
        [JsonPropertyName("down.bounce.offset")]
        public float down_bounce_offset { get; init; } = 0;
        [JsonPropertyName("down.bounce.groundlevel")]
        public Coordinate_Struct down_bounce_ground_level { get; init; } = default;
        [JsonPropertyName("down.friction.threshold")]
        public float down_friction_threshold { get; init; } = 0;
    }
}