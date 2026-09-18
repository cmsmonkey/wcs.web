namespace WCS.Net.Models;

// Real brand copy for Klinger Westad, KSB Amri, PK Valves, and Royal Goodwin. Photos are
// still placeholders for KSB Amri, PK Valves, and Royal Goodwin — swap in real photography
// once it's available. Klinger Westad already carries the real HQ/Acto actuator parts
// photos and the LPG seals callout, since both are specific to that brand.
public static class ValveCatalog
{
    public static readonly IReadOnlyList<ValveViewModel> All = new[]
    {
        new ValveViewModel
        {
            Slug = "klinger-westad",
            Name = "Klinger Westad",
            Kicker = "Service & Spare Parts",
            Teaser = "Full parts and service support for Klinger Westad LNG butterfly valves and actuators — including seals for gate valves the manufacturer no longer makes.",
            ThumbnailSrc = "/images/valves/klinger-westad/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Klinger Westad",
            IntroParagraphs = new[]
            {
                "Klinger Westad LNG butterfly valves are among the most widely used cryogenic valves on LNG carriers worldwide. WCS was the first independent company to give shipowners a genuine alternative for spares and service.",
                "We supply the full range of Klinger Westad spare and actuator parts — including HQ limitswitch boxes, Acto distribution bars, and HQ/Acto cylinder seal kits — and carry out service and overhaul both on board and in dock. Our metal seals are manufactured in-house in Norway; we're also the only supplier of seals for older Klinger Westad gate valves the manufacturer no longer produces. Every WCS-manufactured part carries our 25% Price Guarantee against the OEM price.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-before.jpg", Alt = "A worn HQ limitswitch box after years of service", Caption = "HQ LIMITSWITCH BOX — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/hq-limitswitch-after.jpg", Alt = "A 316L stainless steel limitswitch box manufactured by WCS", Caption = "316L STAINLESS STEEL LIMITSWITCH BOX — WCS" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-before.jpg", Alt = "A worn Acto distribution bar, corroded", Caption = "ACTO DISTRIBUTION BAR — AS RECEIVED" },
                new ValvePhoto { Src = "/images/parts/acto-distribution-bar-after.jpg", Alt = "A newly machined Acto distribution bar manufactured by WCS", Caption = "ACTO DISTRIBUTION BAR — WCS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-1.jpg", Alt = "HQ and Acto cylinder seal kit, assembled", Caption = "HQ & ACTO CYLINDER SEAL KITS" },
                new ValvePhoto { Src = "/images/parts/seal-kit-2.jpg", Alt = "HQ and Acto cylinder seal kit, alternate", Caption = "HQ 400 CYLINDERS — MORE SIZES IN PROGRESS" },
                new ValvePhoto { Src = "/images/parts/hydraulic-block-blind-plug.jpg", Alt = "HQ hydraulic block blind plug", Caption = "HQ HYDRAULIC BLOCK BLIND PLUG" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals 150–250 mm",
                "LNG PTFE Seals 150–600 mm",
                "LPG HPBV Seals 150–350 mm",
                "LNG Spares & Actuator Parts",
                "General Consumables (Locking Wire, Molykote & Lubricants)",
            },
            Callout = new ValveCallout
            {
                Kicker = "New",
                Title = "LPG seals, now available from WCS",
                Body = "Following repeated requests from customers, WCS now supplies LPG seals for Klinger Westad " +
                       "valves — designed as a direct, fully compatible OEM replacement. We're building stock of " +
                       "the most common sizes for shorter lead times and fast worldwide delivery. The 25% Price " +
                       "Guarantee applies here too.",
            },
        },
        new ValveViewModel
        {
            Slug = "ksb-amri",
            Name = "KSB Amri",
            Kicker = "Service & Spare Parts",
            Teaser = "Independent parts and service for KSB Amri LNG butterfly valves and actuators, including HQ actuator cylinders and Danais-size metal seals.",
            ThumbnailSrc = "/images/valves/ksb-amri/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for KSB Amri",
            IntroParagraphs = new[]
            {
                "KSB Amri LNG butterfly valves use the same metal-to-metal sealing technology as Klinger Westad.",
                "We supply spare parts, actuator parts, flange gaskets, and HQ actuator cylinders for KSB Amri equipment, with service on board or in dock. Metal seals, including the larger Danais-size range, are manufactured in-house in Norway, backed by our 25% Price Guarantee against the OEM price.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-1.svg", Alt = "Placeholder photo of KSB Amri valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-2.svg", Alt = "Placeholder photo of KSB Amri valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-3.svg", Alt = "Placeholder photo of KSB Amri valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/ksb-amri/photo-4.svg", Alt = "Placeholder photo of KSB Amri valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals (Danais) 300–500 mm",
                "LNG Spares, Gaskets & Actuator Parts",
                "HQ Actuator Cylinders",
                "General Consumables (Locking Wire, Molykote & Lubricants)",
            },
        },
        new ValveViewModel
        {
            Slug = "pk-valves",
            Name = "PK Valves",
            Kicker = "Service & Spare Parts",
            Teaser = "WCS now supplies metal-to-metal seals for PK Valves — the newest addition to our LNG butterfly valve aftermarket range.",
            ThumbnailSrc = "/images/valves/pk-valves/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for PK Valves",
            IntroParagraphs = new[]
            {
                "PK Valves use the same metal-to-metal sealing technology found in Klinger Westad and KSB Amri LNG butterfly valves. WCS is now entering the market for PK valve seals as well.",
                "This is our newest valve line — we're building out parts and service coverage starting with metal seals in the 400–550 mm range, with more sizes to follow. Contact us to check availability for your specific valve.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-1.svg", Alt = "Placeholder photo of PK Valves valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-2.svg", Alt = "Placeholder photo of PK Valves valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-3.svg", Alt = "Placeholder photo of PK Valves valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/pk-valves/photo-4.svg", Alt = "Placeholder photo of PK Valves valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Metal Seals 400–550 mm",
                "General Consumables (Locking Wire, Molykote & Lubricants)",
            },
        },
        new ValveViewModel
        {
            Slug = "royal-goodwin",
            Name = "Royal Goodwin",
            Kicker = "Service & Spare Parts",
            Teaser = "The only independent supplier of seals for legacy Royal Goodwin LNG valves no longer supported by the manufacturer.",
            ThumbnailSrc = "/images/valves/royal-goodwin/thumb.svg",
            ThumbnailAlt = "Placeholder card thumbnail for Royal Goodwin",
            IntroParagraphs = new[]
            {
                "Royal Goodwin LNG valves are still in service on many older LNG carriers, but Royal Goodwin no longer produces seals for them — leaving shipowners with few options for keeping this equipment running.",
                "WCS is the only supplier able to manufacture and supply seals for older Royal Goodwin valves, with the same 25% Price Guarantee we offer across our full range.",
            },
            Photos = new[]
            {
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-1.svg", Alt = "Placeholder photo of Royal Goodwin valve, 1 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-2.svg", Alt = "Placeholder photo of Royal Goodwin valve, 2 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-3.svg", Alt = "Placeholder photo of Royal Goodwin valve, 3 of 4" },
                new ValvePhoto { Src = "/images/valves/royal-goodwin/photo-4.svg", Alt = "Placeholder photo of Royal Goodwin valve, 4 of 4" },
            },
            SealTypes = new[]
            {
                "LNG Seals 250–400 mm",
                "General Consumables (Locking Wire, Molykote & Lubricants)",
            },
        },
    };

    public static ValveViewModel? FindBySlug(string slug) =>
        All.FirstOrDefault(v => string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));

    /// <summary>All valve types other than the given slug — used for "other valve types" cards.</summary>
    public static IEnumerable<ValveViewModel> AllExcept(string slug) =>
        All.Where(v => !string.Equals(v.Slug, slug, StringComparison.OrdinalIgnoreCase));
}
